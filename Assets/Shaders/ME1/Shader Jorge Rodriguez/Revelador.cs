using UnityEngine;
[ExecuteAlways]
public class Revelador : MonoBehaviour
{

    [SerializeField] private Transform _object;
   [SerializeField] private float colliderRadius;

    private void Start()
    {
        colliderRadius = GetComponent<SphereCollider>().radius;
    }

    void Update()
    {

        Shader.SetGlobalVector("_RevealerPosition", _object.position);
        Shader.SetGlobalFloat("_Radius", (colliderRadius * _object.localScale.x));
    }
}
