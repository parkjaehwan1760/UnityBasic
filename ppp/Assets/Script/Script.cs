using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Script : MonoBehaviour
{
    private string name = "����ȯ";
    private int age = 26;
    private float height = 178f;
    private string hobby = "����";
    private string favoriteFood = "ġŲ";
    private string MBTI = "ISFP";

    void Start()
    {
        Debug.Log($"�ȳ��ϼ���, �� �̸��� {name}�Դϴ�.");
        Debug.Log($"���� {age}���̰�, Ű�� {height}cm�Դϴ�.");
        Debug.Log($"�� ��̴� {hobby}�̰�, ���� �����ϴ� ������ {favoriteFood}�Դϴ�.");
        Debug.Log($"�� MBTI�� {MBTI}�Դϴ�.");
    }
}