using System;

[Serializable]
public class IntRange
{
    public int m_Min; //The minimum value in this range
    public int m_MAx; 



    public IntRange(int min, int max)
    {
        m_MAx = max;
        m_Min = min;
    }

    public int Random
    {
        get {
            return UnityEngine.Random.Range(m_Min, m_MAx;
        }
    }
}

