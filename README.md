# Input.GetAxisでキー入力していないのに0以外が返ってくる

## 概要

![](images/prev.gif)

見えにくいけどキーボードビューアの右下のボタンを見ると押している様が確認できます。
何度か押した後、指を離した後もしばらく1になっていて、マウスを動かすと値が元に戻ることが確認できます。

## 再現方法

1. `Input.GetAxis` を画面に表示する https://github.com/is8r/test-InputGetAxis/blob/main/Assets/Test.cs#L17-L19
2. フレームレートを落とす https://github.com/is8r/test-InputGetAxis/blob/main/Assets/Test.cs#L12
3. 右orDキー（他の方向でも良いけど）を何回か連打する
