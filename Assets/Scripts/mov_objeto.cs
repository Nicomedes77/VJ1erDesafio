using UnityEngine;

public class mov_objeto : MonoBehaviour
{
    public float scaleXYZ = 4.0f;   //factor de escala del objeto
    public float dirX = 0.0f;
    public float dirY = 0.0f;
    public float dirZ = 0.0f;
    public float speed = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        EscalarObjeto();
    }

    // Update is called once per frame
    void Update()
    {
        MoverObjeto();
    }

    void MoverObjeto()
    {
        transform.position += new Vector3(dirX * speed , dirY * speed , dirZ * speed); // Vector3(x,y,z)
        Debug.Log("Jugador moviendose");
    }

    void EscalarObjeto()
    {
        transform.localScale += new Vector3(scaleXYZ,scaleXYZ,scaleXYZ);
        Debug.Log("Jugador escalando");
    }
}
