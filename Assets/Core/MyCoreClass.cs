using UnityEngine;

namespace Mirage
{
    public class MyCoreClass : MonoBehaviour
    {
        public int validate = 0;

        public int _Debug_Weaver()
        {
            // weaver will change this to return (min*60+sec)
            return 0;
        }

        public void OnValidate()
        {
            int time = this._Debug_Weaver();
            string timeStr = $"{time / 3600:00}:{(time / 60) % 60:00}:{time % 60:00}";
            Debug.Log($"Core Time is {timeStr}");
        }
    }
}
