using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * Name:
 * Date:
 * StudentID:
 * Description:
 * Version:
 */

namespace COMP123_S2017_FinalExam_StudentID
{
    public class ScoreBoard
    {
        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private int _score;
        private int _time;
        TextBox _timeTextBox;
        TextBox _scoreTextBox;
        TextBox _finalScoreTextBox;

        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public int Score
        {
            get
            {
                return this._score;
            }

            set
            {
                this._score = value;
                this.ScoreTextBox.Text = this._score.ToString();
                this.FinalScoreTextBox.Text = this._score.ToString();
            }
        }

        public int Time
        {
            get
            {
                return this._time;
            }

            set
            {
                this._time = value;
                this.TimeTextBox.Text = this._time.ToString();
            }
        }

        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }

            set
            {
                this._timeTextBox = value;
            }
        }

        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }

            set
            {
                this._scoreTextBox = value;
            }
        }

        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }

            set
            {
                this._finalScoreTextBox = value;
            }
        }

        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /// <summary>
        /// This is the main constructor.
        /// scoreTextBox and timeTextBox are references to the TextBoxes on the Form
        /// </summary>
        /// <param name="scoreTextBox"></param>
        /// <param name="timeTextBox"></param>
        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            this.ScoreTextBox = scoreTextBox;
            this.TimeTextBox = timeTextBox;
            this.FinalScoreTextBox = finalScoreTextBox;
        }


        // PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This method Updates the Time TextBox
        /// </summary>
        /// <param name="TimeTextBox"></param>
        public void UpdateTime()
        {
            this.Time = Convert.ToInt32(this.TimeTextBox.Text);
            Time -= 1;
            this.TimeTextBox.Text = this.Time.ToString();
        }

    }
}