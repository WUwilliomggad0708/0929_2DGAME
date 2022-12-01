using UnityEngine;
namespace xin
{
    /// <summary>
    /// 敵機發射系統
    /// </summary>
    public class EnemyFireSystem : FireSystemBase
    {
        [SerializeField, Header("生成子彈間隔"), Range(0, 3)]
        private float interval = 1.5f;
        
        
        private void Awake()
        {
            //取消的SpawnBullet();
            //延遲重複呼叫("方法名稱".延續時間.重複頻率)
            InvokeRepeating("SpawnBullet", 0, interval);

        }






    }




}