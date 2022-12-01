using UnityEngine;

namespace xin 
{ 
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("爆炸預置物")]
        private GameObject prefabExplosion;
        [SerializeField, Header("碰到會爆炸的名稱")]
        private string nameTarget;
        [ Header("爆炸與受傷的音效")]
        [SerializeField]
        private AudioClip soundHit;
        [SerializeField]
        private AudioClip soundExplosion;

        //碰到開始執行一次
        private void OnCollisionEnter2D(Collision2D collision)
        {
            print(collision.gameObject.name);
            //如果碰到物件名稱 包含NAMETARGRT 就爆炸並刪除
            if (collision.gameObject.name.Contains(nameTarget));
            {
                //生成爆炸預置物 座標與角度 跟此物件相同
                Instantiate(prefabExplosion, transform.position, transform.rotation);

                SoundManger.instance.PlaySound(soundHit, new Vector2(0.7f, 0.9f));
                SoundManger.instance.PlaySound(soundExplosion, new Vector2(1.2f, 1.5f));

                //刪除Destroy
                //此物件gamepbject
                Destroy(gameObject);
            }
        }
        //碰撞離開時執行一次
        private void OnCollisionExit2D(Collision2D collision)
        {
            
        }
        //碰撞時持續執行
        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }



    }


}