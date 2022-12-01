using UnityEngine;

namespace xin
{
    public class FireSystemBase : MonoBehaviour
    {

        [SerializeField, Header("子彈預置物")]
        private GameObject prefabBullet;
        [SerializeField, Header("子彈生成點")]
        private Transform pointSpawn;
        //生成子彈
        protected void SpawnBullet()
        {
            //實力化(生成物件 座標 角度)
            
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);




        }


    }
}
