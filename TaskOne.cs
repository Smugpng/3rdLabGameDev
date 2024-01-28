using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.Impl;

public class TaskOne : MonoBehaviour
{
    // Public Input Data
    public string courseName;
    public int numberOfModule;
    public int numberOfReading;
    public int numberOfQuiz;
    public int numberOfAssignment;
    public bool hasIntructorTaughtCourseBefore;
    

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(CalculateModuleScore(numberOfModule));
        Debug.Log(CalculateReadingScore(numberOfReading));
        Debug.Log(CalculateQuizScore(numberOfQuiz));
        Debug.Log(CalculateAssignmentScore(numberOfAssignment));
        Debug.Log(CalculateInstructorScore(hasIntructorTaughtCourseBefore));
        Debug.Log(CourseScore());
        Debug.Log(courseName + " Score: " + CourseScore());
    }

    private float CalculateModuleScore(int numberOfModule)
    {
        // Will Assume 10 Weeks in Course and Potential Score of 15%
        float moduleScore = numberOfModule * 10;
        return moduleScore * .15f;
    }

    private float CalculateReadingScore(int numberOfReading)
    {
        // Will Assume 10 Weeks in Course and Potential Score of 30%
        float readingScore = numberOfReading * 10;
        return readingScore * .30f;
    }

    private float CalculateQuizScore(int numberOfQuiz)
    {
        // Will Assume 10 Weeks in Course and Potential Score of 15%
        float quizScore = numberOfQuiz * 10;
        return quizScore * .15f;
    }

    private float CalculateAssignmentScore(int numberOfAssignment)
    {
        // Will Assume 10 Weeks in Course and Potential Score of 30%
        float assignmentScore = numberOfAssignment * 10;
        return assignmentScore * .30f;
    }

    private float CalculateInstructorScore(bool hasIntructorTaughtCourseBefore)
    {
        // Will Assume Potential Score of 10%
        float score = 0.0f;

        if (hasIntructorTaughtCourseBefore)
        {
            score = 10f;
        }

        return score;
    }

    private float CourseScore()
    {
        float maxPossibleScore = 10f;

        // Add Individual Scores
        float preFormattedScore = CalculateModuleScore(numberOfModule) +
                            CalculateReadingScore(numberOfReading) +
                            CalculateQuizScore(numberOfQuiz) +
                            CalculateAssignmentScore(numberOfAssignment) +
                            CalculateInstructorScore(hasIntructorTaughtCourseBefore);

        // Format Total Scores to be out of max possible score (100%)
        return preFormattedScore / maxPossibleScore;

    }
}
