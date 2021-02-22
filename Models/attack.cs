namespace QueenAttack.Models
{
  public class Queen
  {
    public int X{ get; set;}
    public int Y{ get; set;}

    public Queen(int x, int y)
    {
      X=x;
      Y=y;
    }

    public bool Attack(int x, int y)
    {
      //chess board 8x8
      //(0,0)
      //if (x == 0, or y == 0 ) under attack
      // if (x==y)
      //(X,0)
      // if (x == X || y == 0) UA
      // 
    }
  }
}
loop until (x==0 || x== 8 || y == 0 || y == 8)
// (+1,+1)
// (-1,+1)
// (-1,-1)
// (+1,-1)

.........


