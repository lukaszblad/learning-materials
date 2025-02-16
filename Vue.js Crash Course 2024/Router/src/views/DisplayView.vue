<script setup>
    import { ref } from 'vue';
    import { useRoute } from 'vue-router';
    const route = useRoute();
    const valueToDisplay = route.params.value;
    const value = ref(valueToDisplay)
</script>

<template>
    <h1>{{ value }}</h1>
</template>