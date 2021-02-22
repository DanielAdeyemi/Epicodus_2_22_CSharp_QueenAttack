namespace QueenAttack.Models
{
  public class Queen
  {
    public int XQueen{ get; set;}
    public int YQueen{ get; set;}

    public Queen(int x, int y)
    {
      XQueen=x;
      YQueen=y;
    }

    public bool Attack(int x, int y){
      
    if((x==XQueen || y == YQueen) && !(x==XQueen && y==YQueen))
    {
      return true;
    }
    for (int i = 1; i< 7; i++)
    {
      if(XQueen-i<0 && XQueen+i>7 && YQueen-i<0 && YQueen+i>7)
        break;
      if((x == XQueen - i && y == YQueen - i) || 
      (x == XQueen + i && y == YQueen - i) || 
      (x == XQueen + i && y == YQueen + i) || 
      (x == XQueen - i && y == YQueen + i))
        return true;
    }
    return false;
    }
  }
}
// loop until (x==0 || x== 8 || y == 0 || y == 8)
// (+1,+1)
// (-1,+1)
// (-1,-1)
// (+1,-1)

// A and B are Queen coordinates and x and y are piece
// if A > x: y-n(-1) if B > y: y-n(-1)
// 
