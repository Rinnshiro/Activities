using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WordGuessApplication
{
	public partial class frmGuessWord : Form
	{
		private readonly Random rnd = new Random();
		private readonly List<string> words = new List<string>
		{
			"computer",
			"keyboard",
			"monitor",
			"program",
			"language",
			"internet",
			"software",
			"hardware",
			"database",
			"developer",
			"compiler",
			"network",
			"printer",
			"scanner",
			"storage",
			"browser",
			"desktop",
			"laptop",
			"technology",
			"application",
			"algorithm",
			"security",
			"document",
			"function",
			"variable",
			"operator",
			"debugging",
			"interface",
			"windows",
			"android",
			"website",
			"server",
			"system",
			"project",
			"coding",
			"folder",
			"device",
			"digital",
			"memory",
			"process",
			"science",
			"student",
			"teacher",
			"library",
			"notebook",
			"calculator",
			"networking",
			"terminal",
			"framework",
			"solution"
		};

		private readonly HashSet<string> wrongWords = new HashSet<string>();
		private string secretWord = "";
		private StringBuilder displayBuilder;
		private int hintsRemaining = 3;

		public frmGuessWord()
		{
			InitializeComponent();
			StartGame();
		}

		private void StartGame()
		{
			secretWord = words[rnd.Next(words.Count)];
			displayBuilder = new StringBuilder();

			for (int i = 0; i < secretWord.Length; i++)
			{
				if (i == 0 || i == secretWord.Length - 1)
					displayBuilder.Append(secretWord[i]);
				else
					displayBuilder.Append('?');
			}

			hintsRemaining = 3;

			displayWordToGuess.Visible = true;
			displayWordToGuess.Text = displayBuilder.ToString();
			hintCount.Text = "Hint Remaining: " + hintsRemaining;

			wrongWords.Clear();
			wrongGuess.Items.Clear();

			txtYourGuess.Clear();
			txtYourGuess.Enabled = true;
			txtYourGuess.Focus();

			btnGuess.Text = "Guess";
			btnHint.Enabled = true;
		}

		private void FinishGame()
		{
			displayWordToGuess.Text = secretWord;
			txtYourGuess.Enabled = false;
			btnGuess.Text = "Start Again";
			btnHint.Enabled = false;
		}

		private void btnGuess_Click(object sender, EventArgs e)
		{
			if (btnGuess.Text == "Start Again")
			{
				StartGame();
				return;
			}

			string userGuess = txtYourGuess.Text.Trim().ToLower();

			if (string.IsNullOrWhiteSpace(userGuess))
			{
				MessageBox.Show("Please enter a word first.", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtYourGuess.Focus();
				return;
			}

			if (userGuess == secretWord)
			{
				MessageBox.Show("Correct! You guessed the word!", "Correct Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
				FinishGame();
				return;
			}

			if (wrongWords.Add(userGuess))
			{
				wrongGuess.Items.Add(userGuess);
			}

			MessageBox.Show("Wrong guess. Try again!", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			txtYourGuess.Clear();
			txtYourGuess.Focus();
		}

		private void btnHint_Click(object sender, EventArgs e)
		{
			if (btnGuess.Text == "Start Again")
				return;

			if (hintsRemaining <= 0)
			{
				MessageBox.Show("No more hints remaining.", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnHint.Enabled = false;
				return;
			}

			bool revealed = false;

			for (int i = 1; i < secretWord.Length - 1; i++)
			{
				if (displayBuilder[i] == '?')
				{
					displayBuilder[i] = secretWord[i];
					hintsRemaining--;
					revealed = true;
					break;
				}
			}

			displayWordToGuess.Text = displayBuilder.ToString();
			hintCount.Text = "Hint Remaining: " + hintsRemaining;

			if (hintsRemaining <= 0)
			{
				btnHint.Enabled = false;
			}

			if (displayBuilder.ToString() == secretWord)
			{
				MessageBox.Show("The word has been fully revealed!", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Information);
				FinishGame();
				return;
			}

			if (revealed)
			{
				txtYourGuess.Focus();
			}
		}

		private void displayWordToGuess_Click(object sender, EventArgs e)
		{
		}

		private void txtYourGuess_TextChanged(object sender, EventArgs e)
		{
		}

		private void wrongGuess_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void hintCount_Click(object sender, EventArgs e)
		{
		}
	}
}