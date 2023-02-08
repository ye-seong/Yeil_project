using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public static int ending = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(Counter.value == 3)
        {
            //Debug.Log("Ű�� 3�� ��� ��ҽ��ϴ�!");

            if(collision.gameObject.tag == "Goal")
            {
                //Debug.Log("����Ŭ����!");
                ending = 1;
                Time.timeScale = 0;
            }
        }

        if(collision.gameObject.tag == "enemy")
        {
            //Debug.Log("���ӿ���!");
            ending = 2;
            Time.timeScale = 0;
            
        }
    }
}
