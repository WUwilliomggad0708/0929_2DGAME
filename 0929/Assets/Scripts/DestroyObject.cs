using UnityEngine;

namespace xin
{ 

    public class DestroyObject : MonoBehaviour
    {
        [SerializeField, Header("刪除時間"), Range(0, 3)]
        private float destroyTime = 0.5f;
        private void Awake()
        {
            //刪除(物件時間)
            Destroy(gameObject, destroyTime);
        }

        //可見事件:渲染元件出現在scene 或game執行一次
        private void OnBecameVisible()
        {
            
        }
        //可見事件:渲染元件消失在scene 或game執行一次
        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }


    }

}