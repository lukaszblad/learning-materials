<script setup>
    import { defineProps } from 'vue';
    defineProps({
        title: {
            type: String,
            default: "Hello Vue!"
        }
    })
</script>

<template>
    <h1>{{ title }}</h1>
</template>

