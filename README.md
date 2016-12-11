[![Build status](https://ci.appveyor.com/api/projects/status/7m2j8rd1ye54mmit?svg=true)](https://ci.appveyor.com/project/tar-bin/kmbeditor/build/artifacts)

KMBEditor
==

※現状まだ開発途中です。実用に耐えうるものではありません。

# これはなに？

AA(アスキーアート) 作成用エディタ(になる予定のもの)です。

当面はOrinrinEditorの補助的なツール、将来的には代替+αを目標としています。

+ [SikigamiHNQ/OrinrinEditor: AsciiArt Story Editor for Japanese Only](https://github.com/SikigamiHNQ/OrinrinEditor)
+ [OrinrinEditor | やる夫 Wiki | Fandom powered by Wikia](http://yaruo.wikia.com/wiki/OrinrinEditor)

# 使用方法・オンラインドキュメント
詳しいドキュメントは以下を参照してください。

[Introduction · KMBEditor Document](https://tar-bin.gitbooks.io/kmbeditor-document/content/)

# コンセプト

+ 新規AA作成補助をメイン機能とする
+ 多言語対応はしない（日本語のみ）
+ オープンソース / フリーソフトウェア（[GPLv3](https://www.gnu.org/licenses/gpl-3.0.ja.html) : [日本語訳](https://mag.osdn.jp/07/09/02/130237)）

# サポート環境

+ Windows 7 ( .Net Framework 4.5 以上のランタイム必須 ※1 )
+ Windows 8 / 8.1
+ Windows 10

※ Window Vista / XP 以前はサポート外となります。[OrinrinEditor](http://yaruo.wikia.com/wiki/OrinrinEditor)をご利用ください。  
※1 :  .Net Framework 4.5 以上のランタイムについて  
必要に応じて[Microsoftの公式ページ](https://msdn.microsoft.com/ja-jp/library/5a4x27ek(v=vs.110).aspx)から、.NET Framework 4.5 以上のランタイムをインストールしてください。  
Windows 8 以降は標準で .NET Framework 4.5 以上がインストールされているため、基本的に対応は必要ありません。  

# 免責事項
+ 当ソフトウェアおよび当ソフトウェアを改変/再配布されたものを利用したことによるいかなる損害も作者は一切の責任を負いません。自己の責任の上でご利用ください。

# 開発環境
## 開発言語

+ C# 6.0

## 使用フレームワーク/ライブラリ

+ [Microsoft .NET Framework 4.5 (Microsoft Reference Source License)](https://www.microsoft.com/ja-jp/download/details.aspx?id=30653)
+ [Livet 1.3.0 (zlib/libpng License)](http://ugaya40.hateblo.jp/entry/Livet)
+ [ReactiveProperty 3.4.0 (MIT License)](https://github.com/runceel/ReactiveProperty)
+ [Json.NET 9.0.1 (MIT License)](http://www.newtonsoft.com/json)

## アイコン画像

+ [Icon8](https://icons8.com/)([CC BY-ND 3.0](https://icons8.com/license/))

## 開発環境

+ Visual Studio 2015

# Q & A

Q1. AAの回覧機能だけほしい

A1. [AAMZ Viewer](http://aa.yaruyomi.com/)をご使用ください。