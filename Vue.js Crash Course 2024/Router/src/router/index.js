import { createRouter, createWebHistory } from 'vue-router';
import HomeView from '@/views/HomeView.vue';
import AboutView from '@/views/AboutView.vue';
import NotFoundView from '@/views/NotFoundView.vue';
import DisplayView from '@/views/DisplayView.vue';

const router = createRouter({
    history: createWebHistory(import.meta.env.BASE_URL),
    routes: [{
        path: '/',
        name: 'home',
        component: HomeView
    },
    {
        path: '/about/',
        name: 'about',
        component: AboutView
    },
    {
        path: '/display/:value',
        name: 'display',
        component: DisplayView
    },
    {
        path: '/:catchAll(.*)',
        name: 'not-found',
        component: NotFoundView
    }]
})

export default router;
