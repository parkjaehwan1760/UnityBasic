using System;
using UnityEngine;

//star += "��"; // ��
//star += "��"; // ��ĭ
//star += "\n"; // �ٹٲ�


public class Star : MonoBehaviour
{
    string star;

    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        star = string.Empty; // ������ ���� �� ���ڿ��� ���ϴ�.

        // ������ 1: �� �ٿ� �ش� �� ��ȣ��ŭ ���� ��� ����
        // ����: 5���� ����մϴ�. ���Ͻø� numberOfLines ���� �����ϼ���.
        int numberOfLines = 5;

        for (int i = 1; i <= numberOfLines; i++) // i�� ���� ���� ��ȣ (1���� numberOfLines����)
        {
            // C#�� string �����ڸ� ����Ͽ� i���� �� ���ڿ��� ����ϴ�.
            string lineOfStars = new string('��', i);

            // star ������ ���� ���� ����� �ٹٲ� ���ڸ� �߰��մϴ�.
            star += lineOfStars;
            star += "\n"; // �ٹٲ� �߰�

            // ����: ���� �ڵ��� Console.Write("��") �� Console.Write("\n") �κ���
            // Unity���� Debug.Log�� ���� ����ϱ� ���� star ������ �����ϴ� ������� ����Ǿ����ϴ�.
            // ���� �ܼ� ��ó�� �ǽð� ����� �ʿ��ϴٸ� �� �κ��� Console.Write�� �����ؾ� �մϴ�.
            // ������ Unity ȯ�濡���� Debug.Log�� �� ���� ����ϴ� ���� �Ϲ����Դϴ�.
        }

        // ��� ���� �� ������ �ϼ��Ǹ� Debug.Log�� Unity �ֿܼ� ����մϴ�.
        Debug.Log("--- Phase 1 ��� ---");
        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;

        int height = 5; // �̹��������� ù �ٿ� 5���� ���� �ֽ��ϴ�.

        // ������ �Ʒ��� �������鼭 ���� ������ �پ���, ������ �þ�ϴ�.
        for (int i = height; i >= 1; i--) // i�� ���� ���� �� ���� (height���� 1���� ����)
        {
            // 1. ���� �߰�: (height - i) ��ŭ ������ �߰��Ͽ� ������ ����
            //    ��: height=5, i=5 (ù ��): ���� 0��
            //    ��: height=5, i=4: ���� 1��
            //    ��: height=5, i=1 (������ ��): ���� 4��
            star += new string(' ', height - i);

            // 2. �� �߰�: i ��ŭ ���� �߰�
            star += new string('��', i);

            star += "\n"; // �ٹٲ�
        }

        Debug.Log("--- Phase 2 ��� ---");
        Debug.Log(star);
    }



public void Phase3()
    {
        star = string.Empty; // ������ ���� �� ���ڿ��� ���ϴ�.

        // ������ �ִ� �ʺ�/���̸� �����մϴ�.
        int maxHeight = 5; // �̹������� ���� �� ���� 5�� ���Դϴ�.

        // 1. ���� ���� ���� ���� (�� ������ �����ϴ� �κ�)
        for (int i = 1; i <= maxHeight; i++) // i�� ���� ���� �� ���� (1���� maxHeight����)
        {
            star += new string('��', i); // i���� ���� �߰� (���� ����)
            star += "\n"; // �ٹٲ� �߰�
        }

        // 2. �Ʒ��� ���� ���� ���� (�� ������ �����ϴ� �κ�)
        // ���� �� �� (maxHeight) �ٷ� ���� �ٺ��� �����Ͽ� �� ������ 1�� �� ������ �پ��ϴ�.
        for (int i = maxHeight - 1; i >= 1; i--) // i�� ���� ���� �� ���� (maxHeight-1���� 1���� ����)
        {
            star += new string('��', i); // i���� ���� �߰� (���� ����)
            star += "\n"; // �ٹٲ� �߰�
        }

        Debug.Log("--- Phase 3 ��� ---");
        Debug.Log(star);
    }

    public void Phase4()
    {
        int height = 5; // ���� ���� (���� �ִ� ����)
        star = string.Empty;

        for (int i = 1; i <= height; i++)
        {
            // ��ĭ (height - i)��
            for (int j = 0; j < height - i; j++)
            {
                star += "��"; // ���� ���� ���
            }
            // �� (i)��
            for (int k = 0; k < i; k++)
            {
                star += "��"; // �� ���� ���
            }
            star += "\n"; // �ٹٲ�
        }

        // �Ʒ��κ� (���� �پ��� ��, ���� �� �� ����)
        for (int i = height - 1; i >= 1; i--)
        {
            // ��ĭ (height - i)��
            for (int j = 0; j < height - i; j++)
            {
                star += "��"; // ���� ���� ���
            }
            // �� (i)��
            for (int k = 0; k < i; k++)
            {
                star += "��"; // �� ���� ���
            }
            star += "\n";
        }
        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        int height = 5; // ���̾Ƹ���� ���� ���� (���κа� �Ʒ��κ��� �� ��)
        // ������ 5
        // 1. ���̾Ƹ���� ���κ� (�Ƕ�̵� ����)
        // �� �� i�� 0���� height-1���� �����մϴ�.
        // �� ���� (height - 1 - i)���� ����� (2 * i + 1)���� ���� �����˴ϴ�.
        for (int i = 0; i < height; i++)
        {
            // �պκ� ���� �߰�
            for (int j = 0; j < height - 1 - i; j++)
            {
                star += "��"; // ���� ����
            }

            // �� �߰�
            for (int k = 0; k < 2 * i + 1; k++)
            {
                star += "��"; // �� ����
            }
            star += "\n"; // �ٹٲ�
        }

        // 2. ���̾Ƹ���� �Ʒ��κ� (���Ƕ�̵� ����)
        // �� �� i�� height-2���� 0���� �����մϴ�.
        // (���� ���� ���� ���κп��� �̹� �׷����Ƿ� height-1�� �ƴ� height-2���� ����)
        // �� ���� (height - 1 - i)���� ����� (2 * i + 1)���� ���� �����˴ϴ�.
        for (int i = height - 2; i >= 0; i--)
        {
            // �պκ� ���� �߰�
            for (int j = 0; j < height - 1 - i; j++)
            {
                star += "��"; // ���� ����
            }

            // �� �߰�
            for (int k = 0; k < 2 * i + 1; k++)
            {
                star += "��"; // �� ����
            }
            star += "\n"; // �ٹٲ�
        }


        Debug.Log(star);
    }

}
