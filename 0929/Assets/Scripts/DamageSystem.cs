using UnityEngine;

namespace xin 
{ 
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("爆炸預置物")]
        private GameObject prefabExplosion;
        [SerializeField, Header("碰到會爆炸的名稱")]
        private string nameTarget;

        //碰到開始執行一次
        private void OnCollisionEnter2D(Collision2D collision)
        {
            print(collision.gameObject.name);
        }



    }


}