import { createRouter, createWebHashHistory } from 'vue-router'
import Home from '../views/Home.vue'
import product from '../views/Product.vue'
import manage_product from '../views/ManageProduct.vue'
import manage_account from '../views/ManageAccount.vue'

const routes = [
    { //首頁
        path: '/',
        name: 'Home',
        component: Home
    },
    // {
    //   path: '/about',
    //   name: 'About',
    //   // route level code-splitting
    //   // this generates a separate chunk (about.[hash].js) for this route
    //   // which is lazy-loaded when the route is visited.
    //   component: () => import(/* webpackChunkName: "about" */ '../views/About.vue')
    //
    // },

    { //產品列表
        path: '/list/product',
        name: 'product',
        component: product,
    },
    { //新增產品 管理產品
        path: '/manage/product',
        name: 'manage_product',
        component: manage_product,
    },
    { //帳號相關
        path: '/manage/account',
        name: 'manage_account',
        component: manage_account,
    },
    // {
    // path: window.location.pathname + '/*',
    // path: '/*',
    // redirect: 'https://www.youtube.com/',
    // component: Home
    // hidden: true
    // },
]

const router = createRouter({
    history: createWebHashHistory(),
    routes
})

export default router
