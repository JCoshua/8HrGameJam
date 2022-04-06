using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerInputBehavior : MonoBehaviour
{
    private PlayerMovementBehavior _playerMovement;
    private GameObject _activeObject = null;

    public GameObject ActiveObject
    { 
        get { return _activeObject; }
        set { _activeObject = value; }
    }

    // Start is called before the first frame update
    void Awake()
    {
        _playerMovement = GetComponent<PlayerMovementBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forwardMovement = gameObject.transform.forward * Input.GetAxisRaw("Vertical");
        Vector3 horiznotalMovement = gameObject.transform.right * Input.GetAxisRaw("Horizontal");
        Vector3 verticalMovement = new Vector3(0, Input.GetAxisRaw("Jump"), 0);
        _playerMovement.MoveDirection = (forwardMovement + horiznotalMovement + verticalMovement).normalized;

        if(Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
