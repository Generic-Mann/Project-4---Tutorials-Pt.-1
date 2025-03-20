using UnityEngine;

public class Shop : MonoBehaviour
{

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret()
    {
        Debug.Log("Standard Turret selected");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }

    public void PurchaseMissleLauncherTurret()
    {
        Debug.Log("Missle Launcher selected");
        buildManager.SetTurretToBuild(buildManager.missleLauncherPrefab);
    }
}
