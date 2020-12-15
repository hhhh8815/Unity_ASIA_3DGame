using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    [Header("NPC 資料")]
    public NPCData data;
    [Header("對話框")]
    public GameObject dialog;
    [Header("對話內容")]
    public Text textContent;

    /// <summary>
    /// 玩家是否進入感應區
    /// </summary>
    public bool playerInArea;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "小明")
        {
            playerInArea = true;
            Dialog();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "小明")
        {
            playerInArea = false;
        }
    }

    private void Dialog()
    {
        // print(data.dialogA);            // 取得字串全部資料
        // print(data.dialogA[0]);         // 取得字串局部資料：語法 [編號]

        // for 迴圈：重複處理相同程式
        //for (int i = 0; i < 10; i++)
        //{
        //    print("我是迴圈：" + i);
        //}

        //for (int apple = 1; apple < 100; apple++)
        //{
        //    print("迴圈：" + apple);
        //}

        // 字串的長度 dialogA.Length
        for (int i = 0; i < data.dialogA.Length; i++)
        {
            print(data.dialogA[i]);
        }
    }
}
