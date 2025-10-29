using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] GameObject[] lasers;

    private bool isFiring = false;

    public void Update()
    {
        ProcessingFiring();
    }

     public void OnFire(InputValue value)
    {

        isFiring = value.isPressed; 

    }

    void ProcessingFiring()
    {
        foreach (GameObject laser in lasers) 
        {
            var emmissionModule = laser.GetComponent<ParticleSystem>().emission;
            emmissionModule.enabled = isFiring;
        }
    }
}
