module.exports = {
    publicPath: "./",
    devServer: {
        proxy: {
            '/api': {
                target: 'http://localhost/smartHomeApi/public/api/v1/',
                pathRewrite: { '^/api': '' },
                changeOrigin: true,
                ws: true
            },
            '/public': {
                target: 'http://localhost/smartHomeApi/public',
                pathRewrite: { '^/public': '' },
                changeOrigin: true,
                ws: true
            },
        }
    }
}