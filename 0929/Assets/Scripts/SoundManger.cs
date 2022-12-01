using UnityEngine;

namespace xin
{ 
    /// <summary>
    /// 音效管理器
    /// </summary>
    /// 套用程式執行要求元件(類型元件)_第一次用腳本給物件時會添加元件
    [RequireComponent(typeof(AudioSource))]
    public class SoundManger : MonoBehaviour
    {
        public static SoundManger instance;
        private AudioSource aud;
        private void Awake()
        {
            instance = this;
            //此類別

            aud = GetComponent<AudioSource>();
            
        }
        ///播放音效
        public void PlaySound(AudioClip sound,Vector2 rangeVolume)
        {
            float volume = Random.Range(rangeVolume.x, rangeVolume.y);
            aud.PlayOneShot(sound, volume);
        }


        
    }
}
