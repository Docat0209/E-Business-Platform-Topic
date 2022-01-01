module.exports = {
    publicPath: "./",
    devServer: {
        proxy: {
            '/api': {
                target: 'http://106.107.216.9/api/',
                pathRewrite: { '^/api': '' },
                changeOrigin: true,
                ws: true
            },
        }
    }
}