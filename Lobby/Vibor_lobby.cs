using Cinemachine;
using Unity.VisualScripting;
using UnityEngine;

public class Vibor_lobby : MonoBehaviour
{
    public static string point = "Lobby";
    private CinemachineVirtualCamera VirtualCamera;
    private float cor = 1f;
    private void Awake()
    {
        VirtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    private void Update()
    {
        if (point == "Skin" || point == "Profil" || point == "Shop")
        {
            if (transform.position.x >= -18)
            {
                cor = -1f;
                transform.position = new Vector3(transform.position.x + cor, transform.position.y, transform.position.z);
            }
            if (VirtualCamera.m_Lens.OrthographicSize <= 5)
            {
                VirtualCamera.m_Lens.OrthographicSize += 1f * Time.deltaTime * 4;
            }
            if (transform.position.y >= 0)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - 1f * Time.deltaTime * 2, transform.position.z);
            }
        }
        if (point == "Lobby")
        {
            if (transform.position.y >= 0)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - 1f * Time.deltaTime * 2, transform.position.z);
            }
            if (transform.position.x <= -0.5f || transform.position.x >= 0.5f)
            {
                if (transform.position.x > 0)
                {
                    cor = -1f;
                }
                else if (transform.position.x < 0)
                {
                    cor = 1f;
                }
                transform.position = new Vector3(transform.position.x + cor, transform.position.y, transform.position.z);
            }
            if (VirtualCamera.m_Lens.OrthographicSize <= 5)
            {
                VirtualCamera.m_Lens.OrthographicSize += 1f * Time.deltaTime * 4;
            }
        }
        else if (point == "Weapon")
        {
            if (transform.position.y <= 1.3f)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + 1f * Time.deltaTime * 2, transform.position.z);
            }
            if (transform.position.x <= -0.5f || transform.position.x >= 0.5f)
            {
                if (transform.position.x > 0)
                {
                    cor = -1f;
                }
                else if (transform.position.x < 0)
                {
                    cor = 1f;
                }
                transform.position = new Vector3(transform.position.x + cor, transform.position.y, transform.position.z);
            }
            if (VirtualCamera.m_Lens.OrthographicSize > 3f)
            {
                VirtualCamera.m_Lens.OrthographicSize -= 1f * Time.deltaTime * 4;
            }
            else if (VirtualCamera.m_Lens.OrthographicSize < 2.8f)
            {
                VirtualCamera.m_Lens.OrthographicSize += 1f * Time.deltaTime * 4;
            }
        }
        else if (point == "Game" || point == "Mission")
        {
            if (transform.position.y <= 1.3f)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + 1f * Time.deltaTime * 2, transform.position.z);
            }
            if (transform.position.x <= 20f)
            {        
                cor = 1f;
                transform.position = new Vector3(transform.position.x + cor, transform.position.y, transform.position.z);
            }
            if (VirtualCamera.m_Lens.OrthographicSize >= 1.2)
            {
                VirtualCamera.m_Lens.OrthographicSize -= 1f * Time.deltaTime * 4;
            }
        }
    }
}
