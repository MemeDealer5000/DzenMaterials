// PlayerScore.cs
using System.Collections.Generic;

public class PlayerScore : MonoBehaviour, ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    private int score;

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (IObserver observer in observers)
        {
            observer.UpdateData(score);
        }
    }

    public void ChangeScore(int value)
    {
        score += value;
        NotifyObservers();
    }

    public int GetScore()
    {
        return score;
    }
}
