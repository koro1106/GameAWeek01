using TMPro;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeText;

    private float limitTime = 3f; // ��������
    private float startDisplayTime = 1f; // �X�^�[�g��\�����鎞��

    public bool isStart = false; //�X�^�[�g���Ă��邩
    private bool countdownFinished = false; //�J�E���g�_�E�����I�����Ă��邩
    private bool showStartText = false;
    void Update()
    {
        // �J�E���g�_�E�����I����ĂȂ��Ȃ�J�E���g�J�n
        if(!countdownFinished)
        {
            limitTime -= Time.deltaTime;

            if (limitTime > 0)
            {
        �@�@�@timeText.text = "  " + Mathf.CeilToInt(limitTime).ToString(); // �����_�ȉ��؂�̂ĕ\��
            }
            else
            {
                // �J�E���g�_�E���I��
                limitTime = 0;
                countdownFinished = true;
                showStartText = true;
                timeText.text = "�X�^�[�g�I";
            }
        }
       else if(showStartText)
        {
            // �X�^�[�g����莞�ԕ\���������\����
            startDisplayTime -= Time.deltaTime;

            if (startDisplayTime <= 0f)
            {
                timeText.text = "";
                isStart = true;
                showStartText = false;
            }
        }
    }
}
