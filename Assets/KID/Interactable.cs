using UnityEngine;

namespace KID
{
    public class Interactable : MonoBehaviour
    {
        [SerializeField, Header("偵測區域")]
        private string nameTrigger = "偵測區域";
        [SerializeField, Header("動畫參數名稱")]
        private string nameAnimation;

        private Animator ani;

        private void Awake()
        {
            ani = GetComponent<Animator>();
        }

        private void OnTriggerEnter(Collider other)
        {
            print($"<color=#9966ff>碰到物件：{other.name}</color>");

            if (other.name.Contains(nameTrigger))
            {
                ani.SetTrigger(nameAnimation);
            }
        }
    }
}

