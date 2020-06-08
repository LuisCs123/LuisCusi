using UnityEngine;

public class AreaGenerator : MonoBehaviour
{
    public enum PILE_LENGTH { increase,decrease }

    [SerializeField] private Vector3 size = Vector3.one;  
    private PILE_LENGTH pileLength = PILE_LENGTH.increase;
    private int separation = 0;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;       
        Gizmos.DrawWireCube(transform.position, new Vector3(size.x, size.y,size.z));
    }
}
