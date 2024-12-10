using UnityEngine;
using Cinemachine;
using Unity.VisualScripting;
using System.Diagnostics.Tracing;
using System;

public class Camera_work : MonoBehaviour
{
    private CinemachineVirtualCamera VirtualCamera;
    public static GameObject Cels;
    public static GameObject Player;
    public static GameObject Bullet;
    [SerializeField] private GameObject Otl;
    public static float timeng;
    

    private void Awake()
    {
        VirtualCamera = GetComponent<CinemachineVirtualCamera>();
        VirtualCamera.Follow = Otl.transform;
        Cels = Otl;
    }

    private void Update()
    {
        if (Menu.Pauses == false)
        {
            if (Machine.cel <= 0 && Machine.time >= timeng)
            {
                Cels = Otl;
            }
            if (Menu.menush == false)
            {
                if (Generaishonhome.start == false && Machine.ustran == true)
                {
                    VirtualCamera.Follow = Otl.transform;
                }
                if (Machine.time < 1 && Generaishonhome.start == true && Machine.cel >= 1 && Machine.ustran == true)
                {
                    VirtualCamera.Follow = Cels.transform;
                }
                if (Machine.time < 1 && Machine.cel >= 1 && Machine.ustran == false)
                {
                    VirtualCamera.Follow = Cels.transform;
                }
                if (Machine.time >= 1 && Machine.time <= 1.5 && Generaishonhome.start == true && Machine.ustran == true)
                {
                    VirtualCamera.Follow = Player.transform;
                }
                if (Machine.worked == true)
                {
                    VirtualCamera.Follow = Bullet.transform;
                    if (Bullet.transform.position.x > Cels.transform.position.x)
                    {
                        timeng = Machine.time + 1;
                        Machine.worked = false;
                    }
                }
                if (Machine.worked == false && Machine.time >= 1 && Machine.time >= timeng)
                {
                    VirtualCamera.Follow = Player.transform;
                }
                if (Machine.worked == true && Cels.transform.position.x - Bullet.transform.position.x <= 5 && Machine.time_freez >= 0.1f && Cels.transform.position.x - Bullet.transform.position.x >= 1 && VirtualCamera.m_Lens.OrthographicSize >= 2)
                {
                    Machine.time_freez -= Time.deltaTime * 2f;
                    VirtualCamera.m_Lens.OrthographicSize -= 1f * Time.deltaTime;
                }
                if (Machine.worked == false && VirtualCamera.m_Lens.OrthographicSize <= 5)
                {
                    VirtualCamera.m_Lens.OrthographicSize += 1f * Time.deltaTime;
                }
            }
        }
    }
   
}
