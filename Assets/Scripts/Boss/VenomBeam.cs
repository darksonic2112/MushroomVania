using System.Collections;
using UnityEngine;

public class VenomBeam : MonoBehaviour
{
    public GameObject venomBeam;
    public GameObject venomBeamIndicator;

    public GameObject venomBeam2;
    public GameObject venomBeamIndicator2;

    public GameObject venomBeam3;
    public GameObject venomBeamIndicator3;
    void Start()
    {
        bossAttack.VenomBeam += VenomBeamAttack;
        venomBeam.SetActive(false);
        venomBeamIndicator.SetActive(false);
        venomBeam2.SetActive(false);
        venomBeamIndicator2.SetActive(false);
        venomBeam3.SetActive(false);
        venomBeamIndicator3.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log("VenomBeamAttack starts");
            VenomBeamAttack();
        }
    }

    IEnumerator Attack()
    {
        venomBeamIndicator.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        venomBeamIndicator.SetActive(false);
        venomBeam.SetActive(true);
        venomBeamIndicator2.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        venomBeam.SetActive(false);
        venomBeamIndicator2.SetActive(false);
        venomBeam2.SetActive(true);
        venomBeamIndicator3.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        venomBeam2.SetActive(false);
        venomBeamIndicator3.SetActive(false);
        venomBeam3.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        venomBeam3.SetActive(false);
    }

    public void VenomBeamAttack()
    {
        StartCoroutine(Attack());
    }
}
