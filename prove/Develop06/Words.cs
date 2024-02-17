using System;
using System.Diagnostics.Metrics;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

public class Word {

  // Private members encapsulate state.
  private string text;
  private bool hidden;
  private int index;

  // Constructors to initialize.
  public Word(string text) {
    this.text = text; 
  }

  public Word(string text, int index) {
    this.text = text;
    this.index = index;
  }

  // Getters encapsulate access to private state.
  public int GetIndex() {
    return this.index;
  }

  // Methods to modify state.
  public void Hide() {
    this.hidden = true;
  }

  public bool IsHidden() {
    return this.hidden; 
  }

  // Abstraction method.
  public override string ToString() {
    if (!this.hidden) {
      return this.text;
    }

    int len = this.text.Length;
    string output = "";
    
    while (len > 0) {
      output += "_";
      len -= 1;
    }

    return output;
  }
}