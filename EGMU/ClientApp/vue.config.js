const MomentLocalesPlugin = require("moment-locales-webpack-plugin");
const path = require("path");

module.exports = {
  pluginOptions: {
    webpackBundleAnalyzer: {
      openAnalyzer: false,
    },
  },
  css: {
    loaderOptions: {
      less: {
        lessOptions: {
          javascriptEnabled: true,
        },
      },
    },
  },
  transpileDependencies: ["oidc-client"],
  configureWebpack: {
    plugins: [
      new MomentLocalesPlugin({
        localesToKeep: ["de"],
      }),
    ],
    resolve: {
      alias: {
        "@ant-design/icons/lib/dist$": path.resolve(
          __dirname,
          "./src/config/icons.js"
        ),
      },
    },
  },
};
