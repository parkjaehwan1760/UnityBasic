using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Arl : MonoBehaviour
{
    string[] Character = {"����", "Ƽ��", "����", "�Ƹ�", "�߽���", "ī�̻�", "��þ�", "��", "��̶�", "����"};
    List<string> CharacterList = new List<string>();

    public void TestGacha()
    { 
        CharacterList.Clear(); // ����Ʈ �ʱ�ȭ
        for (int i = 0; i < 10; i++)
        {
            int randomIndex = Random.Range(0, Character.Length); // 0���� Character.Length - 1������ ���� �ε���
            string selectedCharacter = Character[randomIndex]; // �������� ���õ� ĳ����
            CharacterList.Add(selectedCharacter); // ����Ʈ�� �߰�
        }
        // ��� ���
        foreach (string character in CharacterList)
        {
            Debug.Log($"���� ĳ����: {character}");
        }
    }
}
    


