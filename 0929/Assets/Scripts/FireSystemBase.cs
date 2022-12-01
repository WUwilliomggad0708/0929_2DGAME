using UnityEngine;

namespace xin
{
    public class FireSystemBase : MonoBehaviour
    {

        [SerializeField, Header("子彈預置物")]
        private GameObject prefabBullet;
        [SerializeField, Header("子彈生成點")]
        private Transform pointSpawn;

    }
}
