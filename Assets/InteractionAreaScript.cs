using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionAreaScript : MonoBehaviour
{
    int puntaje;
    public Text txtPuntaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        PickupScript pickup;
        pickup = other.GetComponent<PickupScript>();
        puntaje += pickup.puntosItem;
        txtPuntaje.text = $"PUNTAJE: {puntaje}";
        if(pickup.esComida == true)
        {
            Destroy(other.gameObject);
        }
    }
}
