# MiniLogoMaker

轻量级阴影 Logo 生成器

[README_EN.md](/README_EN.md)

## 功能

- **大小和阴影调整：** 可以修改徽标的大小、阴影位置和颜色。
- **颜色自定义：** 可自定义背景色、前景色和阴影颜色。
- **实时预览：** 实时预览生成的徽标效果。
- **保存和剪贴板：** 可以将生成的徽标保存为 PNG 文件，或复制到剪贴板。

## 细节

- 使用了 [KlxPiao - KlxPiaoAPI](https://github.com/miniyu157/KlxPiao) 中的数个方法用于处理图像
  > ```
  > CreateTransparentBackground
  > ResetImage
  > ReplaceNonFullyTransparentPixels
  > ```
- 使用了 [KlxPiao - KlxPiaoControls](https://github.com/miniyu157/KlxPiao) 用于构造程序的界面
- 封装为了方法，可以复制代码到任何地方使用

![method](/Screenshot/method.png)

![code](/Screenshot/code.png)

## 使用

可以在 [releases](https://github.com/miniyu157/MiniLogoMaker/releases) 页面下载本程序的最新版本

或者使用 Visual Studio 或其他支持 .NET 的 IDE 打开解决方案构建并运行项目

## 预览

![main](/Screenshot/main.png)

## 贡献

欢迎提出问题、建议或创建 Pull request 以改进此项目。

## 许可证

此项目基于 MIT 许可证，详情请参阅 [LICENSE](/LICENSE.txt) 文件。