using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bulletspawn : MonoBehaviour
{
    [SerializeField] GameObject player;
    void Start()
    {
        transform.position = new Vector2(player.transform.position.x + 0.68f, player.transform.position.y+ 0.1613339f); 
    }

    
}
