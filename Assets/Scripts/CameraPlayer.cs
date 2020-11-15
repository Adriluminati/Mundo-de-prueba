using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    private Camera cameraFollowPlayer;
    
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        cameraFollowPlayer = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CameraFollow()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
    }

    private void LateUpdate()
    {
        CameraFollow();
    }
}
