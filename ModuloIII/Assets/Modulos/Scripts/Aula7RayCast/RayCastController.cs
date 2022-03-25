using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastController : MonoBehaviour
{

    public bool Jump;
    public float forceJump = 50f; 
     void Update()
    {
        //Fisica, ray posição, direção tamanho
        // Physics.Raycast(transform.position, transform.forward, 5); 

        // if (Physics.Raycast(transform.position, transform.forward, 10))
        // {
        //       Debug.Log("Collider");          
        // }     
        // else
        // {
        //     Debug.Log("Not Collider");
        // }


        //Mostra uma linha até o objeto que esta collidindo 
        // RaycastHit colliderPoint;

        // if (Physics.Raycast(transform.position, transform.forward, out colliderPoint, 10))
        // {
        //     Debug.Log(colliderPoint.point); 
        //     Debug.DrawLine(transform.position, colliderPoint.point);           
        // }

        //Apaga Objeto ao chegar na distancia 10
        // RaycastHit colliderPoint;

        // if (Physics.Raycast(transform.position, transform.forward, out colliderPoint, 10))
        // {
        //     if(colliderPoint.transform.gameObject.activeSelf)
        //     {
        //         colliderPoint.transform.gameObject.SetActive(false);
        //     }          
        // }

        //Troca a cor do objeto que colidiu
        // RaycastHit colliderPoint;

        // if (Physics.Raycast(transform.position, transform.forward, out colliderPoint, 10))
        // {
        //     if(colliderPoint.transform.gameObject.activeSelf)
        //     {
        //         colliderPoint.transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        //     }          
        // }

        //Pulo do player    
            
        // if (Physics.Raycast(transform.position, -Vector3.up, 0.5f))
        // {
        //     Jump = true;            
        // }
        // else
        // {
        //     Jump = false;
        // }

        // if (Input.GetKeyDown(KeyCode.Space) && Jump == true)
        // {
        //     GetComponent<Rigidbody>().AddForce(Vector3.up * forceJump);            
        // }
    }
}
