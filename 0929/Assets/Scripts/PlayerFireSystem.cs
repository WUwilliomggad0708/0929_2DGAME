using UnityEngine;

namespace xin
{
    /// <summary>
    /// 玩家發射系統
    /// </summary>
    public class PlayerFireSystem : FireSystemBase
    {
        //偵測玩家輸入
        private void Update()
        {
            //玩家案空白建 就生成子彈
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            } 

        }



    }



}