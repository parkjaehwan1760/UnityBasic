using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Script : MonoBehaviour
{
    private string name = "박재환";
    private int age = 26;
    private float height = 178f;
    private string hobby = "게임";
    private string favoriteFood = "치킨";
    private string MBTI = "ISFP";

    void Start()
    {
        Debug.Log($"안녕하세요, 제 이름은 {name}입니다.");
        Debug.Log($"저는 {age}살이고, 키는 {height}cm입니다.");
        Debug.Log($"제 취미는 {hobby}이고, 가장 좋아하는 음식은 {favoriteFood}입니다.");
        Debug.Log($"제 MBTI는 {MBTI}입니다.");
    }
}