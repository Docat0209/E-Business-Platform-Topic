import { createRouter, createWebHistory } from 'vue-router'
import Home from '../views/Home.vue'
import product from '../views/Product.vue'
import manage_product from '../views/ManageProduct.vue'
import manage_account from '../views/ManageAccount.vue'

const routes = [
    { //首頁
        path: window.location.pathname + '/',
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
        path: window.location.pathname + '/list/product',
        name: 'product',
        component: product,
    },
    { //新增產品 管理產品
        path: window.location.pathname + '/manage/product',
        name: 'manage_product',
        component: manage_product,
    },
    { //帳號相關
        path: window.location.pathname + '/manage/account',
        name: 'manage_account',
        component: manage_account,
    },
]

const router = createRouter({
    history: createWebHistory(process.env.BASE_URL),
    routes
})

export default router
