using UnityEngine;

public class FreeCameraController : MonoBehaviour
{


    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(0, 0, -m_fSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(0, 0, m_fSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(-m_fSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(m_fSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 vMouseMovement = new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X")) / m_fAngularSensibility;

            //gameObject.transform.Rotate(vMouseMovement);

            Vector3 vNewOri = gameObject.transform.rotation.eulerAngles + vMouseMovement;
            gameObject.transform.rotation = Quaternion.Euler(vNewOri);

            //gameObject.transform.rotation *= Quaternion.Euler(vMouseMovement);
        }
    }

    [SerializeField]
    private float m_fSpeed = 1f;
    [SerializeField]
    private float m_fAngularSensibility = 0.2f;
}
