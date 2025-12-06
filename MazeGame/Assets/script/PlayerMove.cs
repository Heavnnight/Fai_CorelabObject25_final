using UnityEngine;

public class PlayerFollowMouse : MonoBehaviour
{
    public float depth = 10f;         // المسا﻿فة بين الكاميرا واللاعب
    public float smoothSpeed = 10f;   // سرعة السموث

    void Update()
    {
        // ناخذ موقع الماوس
        Vector3 mousePos = Input.mousePosition;

        // نحدّد موقع اللاعب حسب عمق الكاميرا
        mousePos.z = depth;

        // نحول الماوس من شاشة → عالم
        Vector3 targetPos = Camera.main.ScreenToWorldPoint(mousePos);

        // حركة ناعمة
        transform.position = Vector3.Lerp(transform.position, targetPos, smoothSpeed * Time.deltaTime);
    }
}
