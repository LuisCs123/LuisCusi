using UnityEngine;

[ExecuteInEditMode]
public class RespawnCar : MonoBehaviour
{
    [SerializeField]private GameObject carPrefab = null;
    private Vector3 spawnPosition = Vector3.one;


    void Start()
    {
        spawnPosition = new Vector3(-3, 10, -10);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        Gizmos.DrawWireSphere(spawnPosition, 1);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            SpawnObject();
            Debug.Log("D WAS PRESSED");
        }
    }
    public void SpawnObject()
    {
        Instantiate(carPrefab, spawnPosition, carPrefab.transform.rotation);
    }

}
