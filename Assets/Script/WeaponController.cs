using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [Header("Sonido y Visuales")]
    [SerializeField] AudioClip shootSound = null;
    [SerializeField] AudioClip emptySound = null;
    [SerializeField] AudioClip reloadSound = null;
    ParticleSystem flashEffect;
    AudioSource audioSource;

    [Header("Parametros")]
    public float fireRange = 200;
    public float recoilForce = 4f;
    public float fireRate = 0.06f;
    public int maxAmmo = 15;
    public int currentAmmo;
    public float ReloadTime = 1.5f;
    Animator anim;

    float lastTimeShoot;
    [Header("General")]
    //public LayerMask hitableLayer;
    public GameObject bulletHolePF;


    Transform cameraPlayerTransform;

    private void Awake()
    {
        currentAmmo = maxAmmo;
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        flashEffect = GetComponentInChildren<ParticleSystem>();
        anim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        cameraPlayerTransform = Camera.main.transform;
    }

    private void OnEnable()
    {
        WeaponUI.Instance.EnableWeaponUI(true);
        WeaponUI.Instance.UpdateCurrentBullets(currentAmmo);
        WeaponUI.Instance.UpdateMaxBullets(maxAmmo);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            TryShoot();

        if (Input.GetKeyDown(KeyCode.R))
            StartCoroutine(Reload());

        transform.localPosition = Vector3.Lerp(transform.localPosition, Vector3.zero, Time.deltaTime * 5f);
    }

    bool TryShoot()
    {
        if (lastTimeShoot + fireRate < Time.time && currentAmmo >= 1)
        {
            HandleShoot();
            currentAmmo--;
            WeaponUI.Instance.UpdateCurrentBullets(currentAmmo);
            return true;
        }
        else if (currentAmmo <= 0)
        {
            audioSource.clip = emptySound;
            audioSource.Play();
        }
        return false;
    }

    void HandleShoot()
    {
        AddRecoil();

        flashEffect.Play();

        audioSource.clip = shootSound;
        audioSource.Play();

        RaycastHit hit;

        lastTimeShoot = Time.time;

        if (Physics.Raycast(cameraPlayerTransform.position, cameraPlayerTransform.forward, out hit, fireRange))
        {
            if (hit.collider.tag == "Enemy")
                hit.collider.GetComponent<Enemy>().TakeDamage();
            else if (hit.collider.tag == "Player")
            {
                return;
            }
            else
            {
                GameObject bulletHoleClone = Instantiate(bulletHolePF, hit.point + hit.normal * 0.001f, Quaternion.LookRotation(hit.normal));
                Destroy(bulletHoleClone, 5f);
            }
        }
    }

    void AddRecoil()
    {
        transform.Rotate(-recoilForce, 0f, 0f);
        transform.position = transform.position - transform.forward * (recoilForce/50);
    }

    IEnumerator Reload()
    {
        anim.Play("ReloadPlayer");
        audioSource.clip = reloadSound;
        audioSource.Play();
        yield return new WaitForEndOfFrame();
        yield return new WaitForSeconds(anim.GetCurrentAnimatorStateInfo(0).length);
        currentAmmo = maxAmmo;
        WeaponUI.Instance.UpdateCurrentBullets(currentAmmo);
    }

    private void OnDisable()
    {
        WeaponUI.Instance.EnableWeaponUI(false);
    }
}
