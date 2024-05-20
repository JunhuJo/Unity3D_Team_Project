using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingItem : MonoBehaviour
{
    public BoxCollider healingcollider;
    public ParticleSystem healingEffect;
    Vector3 upposition;
    public SphereCollider sphereCollider;


    private void Awake()
    {
        upposition.y = transform.position.y;
        this.healingcollider = GetComponent<BoxCollider>();
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            healingEffect.Play();
            healingcollider.enabled = false;
            GetHeal();
            sphereCollider.enabled = false;

        }
    }
   
    void GetHeal()
    {
        transform.DOMoveY(upposition.y + 2, 2.0f);
        transform.DORotate(new Vector3(0, 900, 0), 2f,RotateMode.FastBeyond360);
        Invoke("GetHealing", 1.5f);
    }
  
    void GetHealing()
    {
        gameObject.SetActive(false);
    }
}
