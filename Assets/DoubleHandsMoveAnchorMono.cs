using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleHandsMoveAnchorMono : MonoBehaviour
{
    public Transform m_observerPoint;
    public Transform m_objectToMove;

    public float m_amplifyMove = 2;
    public float m_amplifyRotate = 2;

    public bool m_isMoving;
    public void SetAsMoving(bool isMoving) {

        bool changed = m_isMoving != isMoving;
        if (changed)
        { 
            if(isMoving) {
                m_start = new PointAnchor();
                m_start.m_position = m_observerPoint.position;
                m_start.m_rotation = m_observerPoint.rotation;

            } else {
                m_end = new PointAnchor();
                m_end.m_position = m_observerPoint.position;
                m_end.m_rotation = m_observerPoint.rotation;

                //Quaternion rotation = m_end.m_rotation * Quaternion.Inverse(m_start.m_rotation);
                //FlatToHorizontalRotation(ref rotation);
                //Vector3 position = m_end.m_position - m_start.m_position;
                //rotation = Quaternion.Lerp(Quaternion.identity, rotation, m_amplifyRotate);
                //m_objectToMove.position +=m_start.m_position +  position * m_amplifyMove;
                //m_objectToMove.rotation *=m_start.m_rotation *  rotation;

            }
        }
        m_isMoving = isMoving;
        
    }

    private void FlatToHorizontalRotation(ref Quaternion rotation)
    {
        Vector3 euler = rotation.eulerAngles;
        euler.x = 0;
        euler.z = 0;
        rotation = Quaternion.Euler(euler);
    }

    public PointAnchor m_start;
    public PointAnchor m_current;
    public PointAnchor m_end;

        [System.Serializable]
    public class PointAnchor {
        public Vector3 m_position;
        public Quaternion m_rotation;
    }
   

    void Update()
    {
        if (m_isMoving) { 
            m_current = new PointAnchor();
            m_current.m_position = m_observerPoint.position;
            m_current.m_rotation = m_observerPoint.rotation;
            Quaternion rotation = m_current.m_rotation * Quaternion.Inverse(m_start.m_rotation);

            // get a "forward vector" for each rotation
            var forwardA = Quaternion.identity * Vector3.forward;
            var forwardB = rotation * Vector3.forward;

            // get a numeric angle for each vector, on the X-Z plane (relative to world forward)
            var angleA = Mathf.Atan2(forwardA.x, forwardA.z) * Mathf.Rad2Deg;
            var angleB = Mathf.Atan2(forwardB.x, forwardB.z) * Mathf.Rad2Deg;

            // get the signed difference in these angles
            var angleDiff = Mathf.DeltaAngle(angleA, angleB);

            Quaternion r = Quaternion.Euler(0, angleDiff, 0);
//            FlatToHorizontalRotation(ref rotation);
            Vector3 deltaMove = m_current.m_position - m_start.m_position;
            rotation = Quaternion.Lerp(Quaternion.identity, rotation, m_amplifyRotate);
            m_objectToMove.position = m_start.m_position + deltaMove * m_amplifyMove;
            m_objectToMove.rotation =  r;
        }

    }
}
