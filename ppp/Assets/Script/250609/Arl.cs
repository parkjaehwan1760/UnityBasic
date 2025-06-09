using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Arl : MonoBehaviour
{
    string[] Character = {"가렌", "티모", "리신", "아리", "야스오", "카이사", "루시안", "진", "사미라", "조이"};
    List<string> CharacterList = new List<string>();

    public void TestGacha()
    { 
        CharacterList.Clear(); // 리스트 초기화
        for (int i = 0; i < 10; i++)
        {
            int randomIndex = Random.Range(0, Character.Length); // 0부터 Character.Length - 1까지의 랜덤 인덱스
            string selectedCharacter = Character[randomIndex]; // 랜덤으로 선택된 캐릭터
            CharacterList.Add(selectedCharacter); // 리스트에 추가
        }
        // 결과 출력
        foreach (string character in CharacterList)
        {
            Debug.Log($"뽑은 캐릭터: {character}");
        }
    }
}
    


