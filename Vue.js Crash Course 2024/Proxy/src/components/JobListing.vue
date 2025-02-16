<script setup>
    import { defineProps } from 'vue'

    defineProps({
        job: Object,
    });
</script>

<template>
    <div>{{ job.title }}</div>
</template>
