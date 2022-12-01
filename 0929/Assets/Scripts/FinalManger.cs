using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace xin
{
    /// <summary>
    /// 結束管理器
    /// </summary>
    public class FinalManger : MonoBehaviour
    {
        private CanvasGroup groupFinal;

        private TextMeshProUGUI textTitle;

        private Button btnReplay;

        private void Awake()
        {
            groupFinal =  GameObject.Find("結束畫布").GetComponent<CanvasGroup>();
            textTitle = GameObject.Find("結束標題").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("重新遊戲").GetComponent<Button>();
        }



    }
}