public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        // TODO Start Problem 1
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else if (value != Left.Data)
                Left.Insert(value);

        } else if (value > Data) { 
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else if (value != Right.Data) 
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (value < Data) {
            // Search in the left subtree
            if (Left is null)
                return false;
            else
                return Left.Contains(value);

        } else if (value > Data) {
            // Search in the right subtree
            if (Right is null)
                return false;
            else
                return Right.Contains(value);
        } else {
            // Value found
            return true;
        }
    }

    public int GetHeight() {
        // TODO Start Problem 4
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;

        return 1 + Math.Max(leftHeight, rightHeight);
        //return 0;  Replace this line with the correct return statement(s)
    }
}