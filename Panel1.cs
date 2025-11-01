using Godot;
using System;

public partial class Panel1 : Panel
{
    private Random rng = new Random();

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        Label meuLabel = GetNode<Label>("lblTeste");
        meuLabel.Text = "Olá, mundo!";
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        Label meuLabel = GetNode<Label>("lblTeste");
        meuLabel.Text = RandomLetter();
    }

    private string RandomLetter()
    {
        // decide maiúscula ou minúscula aleatoriamente
        bool uppercase = rng.Next(0, 2) == 0;
        int offset = uppercase ? 'A' : 'a';
        char c = (char)(rng.Next(0, 26) + offset);
        return c.ToString();
    }
}
